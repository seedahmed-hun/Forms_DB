namespace new_db;

using System.Data;
using System.Text;
using System.Diagnostics;
using MySql.Data.MySqlClient;

public partial class Form1 : Form
{
     private string GetConnectionString()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrenDirectory()).AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            IConfiguration config = buolder.Build();
            retern config.GetConnectionString("DefaultConnection");
        }
        
    const string conStr = GetConnectionString();
    public Form1()
    {
        InitializeComponent();
        pwd = new Connect_pwd(this);
    }

    public Connect_pwd pwd;
    private void Show_button_Click(object sender, EventArgs e)
    {
        pwd.Show();
        this.Hide();
        try
        {
        MySqlConnection con = new MySqlConnection(conStr);
        String query = "select * from employees";
        MySqlCommand cmd = new MySqlCommand(query,con);
        con.Open();
        MySqlDataReader dr = cmd.ExecuteReader();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();        
        dt.Load(dr);
        dataGridView.DataSource = dt;
            if (dataGridView.Visible == false)
            {
                this.Size = new Size(this.Width, 680);
                dataGridView.Visible = true;
            }
        }
        catch
        {
            MessageBox.Show("Whe have error","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }
    private void Enter_button_Click(object sender, EventArgs e)
    {
        dataGridView.DataSource = ($"{textBox.Text} : {textBox1.Text} {textBox2.Text}");
        try
        {
            MySqlConnection con = new MySqlConnection(conStr);
            MySqlCommand cmd = new MySqlCommand("insert into employees (F_Name, L_Name) values (@fnmae, @lname);",con);
            cmd.Parameters.AddWithValue("@fnmae", textBox1.Text);
            cmd.Parameters.AddWithValue("@lname", textBox2.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Inserted successfully");
            textBox.Clear();
            textBox1.Clear();
            textBox2.Clear();
        }
        catch(Exception error)
        {
            MessageBox.Show(error.InnerException.Message);
        }
    } 
    private void Exit_button_Click(object sender, EventArgs e)
    {
        DialogResult result = MessageBox.Show("Are you whant to exit","Hello",MessageBoxButtons.YesNo);
        if(result == DialogResult.Yes)
        {
            this.Close();
        }
    } 
    private void Delete_button(object select, EventArgs e)
    {
        if (textBox.Text == null)
        {
            MessageBox.Show("You dont enter id ?");
        }else
       {
        try
       {
        MySqlConnection con = new MySqlConnection(conStr);
        MySqlCommand cmd = new MySqlCommand($"delete from employees where id = '{textBox.Text}'",con);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Clone();
        MessageBox.Show("Deletr success");
        textBox.Clear();
        }
        catch
        {
            MessageBox.Show("System can't Delete");
        }
       }
    }
}
