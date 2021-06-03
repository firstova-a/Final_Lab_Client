using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Клиент
{

    public partial class Form1 : Form
    {

        private void Form1_Load(object sender, System.EventArgs e)
        {
            // Bind the DataGridView controls to the BindingSource
            // components and load the data from the database.
            //LentaDGV.DataSource = masterBindingSource;
            //detailsDataGridView.DataSource = detailsBindingSource;
           // GetData();

            // Resize the master DataGridView columns to fit the newly loaded data.
            LentaDGV.AutoResizeColumns();

            // Configure the details DataGridView so that its columns automatically
            // adjust their widths when the data changes.
            LentaDGV.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void AutoSizeRowsMode(Object sender, EventArgs es)
        {
            LentaDGV.AutoSizeRowsMode =  DataGridViewAutoSizeRowsMode.AllCells;
        }
        public static bool flag = false;
        public Form1()
        {
            InitializeComponent();
        }
        public HttpClient client = new HttpClient();

        private async void Log_Click(object sender, EventArgs e)
        {

            string login = Login.Text;
            string pswd = Password.Text;
            MultipartFormDataContent content = new MultipartFormDataContent();
            content.Add(new StringContent(login), "Username");
            content.Add(new StringContent(pswd), "Password");
            var response = client.PostAsync("https://localhost:44381/Account/Login2", content);
            string jsonstring = await (await response).Content.ReadAsStringAsync();
            MainModel mainModel = JsonConvert.DeserializeObject<MainModel>(jsonstring);
            if (mainModel.ErrorMessage == null)
            {
                flag = true;
                OK.Text = "OK";
                Login.Clear();
                Password.Clear();
                //textBox9.Text = mainModel.Balance.ToString();
                foreach (Blog blog in mainModel.Blogs)
                {
                    string birdAll = blog.Bird + "(" + blog.BirdInLatin + ")";

                    LentaDGV.Rows.Add(blog.Id, blog.Author.Login, birdAll, blog.Time, blog.Count, blog.Place, blog.Weather, blog.Comment, blog.Picture);
                }

            }
            else
            {
                OK.Text = mainModel.ErrorMessage;
            }
        }
        /* private async void Out_Click(object sender, EventArgs e)
         {

             Login.Clear();
             Password.Clear();
             var response = client.GetAsync("https://localhost:44381/Account/Logoff2");
             string jsonstring = await (await response).Content.ReadAsStringAsync();
             MainModel mainModel = JsonConvert.DeserializeObject<MainModel>(jsonstring);
             if (mainModel.ErrorMessage == null)
             {
                 OK.Text = "вы вышли";
                 //textBox9.Text = mainModel.Balance.ToString();
                 LentaDGV.ClearSelection();
             }
             else
             {
                 OK.Text = mainModel.ErrorMessage;
             }
         }*/
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void OK_TextChanged(object sender, EventArgs e)
        {

        }

        private async void Out_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                Login.Clear();
                Password.Clear();
                var response = client.GetAsync("https://localhost:44381/Account/Logoff2");
                string jsonstring = await (await response).Content.ReadAsStringAsync();
                MainModel mainModel = JsonConvert.DeserializeObject<MainModel>(jsonstring);
                if (mainModel.ErrorMessage == null)
                {
                    flag = false;
                    OK.Text = "вы вышли";
                    //textBox9.Text = mainModel.Balance.ToString();
                    LentaDGV.Rows.Clear();
                }
                else
                {
                    OK.Text = mainModel.ErrorMessage;
                }
            }
            else { OK.Text = "Необходимо авторизоваться"; };
        }

        private async void Del_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                string Id = IdDel.Text;
                MultipartFormDataContent content = new MultipartFormDataContent();
                content.Add(new StringContent(Id), "id");

                var response = client.PostAsync("https://localhost:44381/Account/DeleteBlog2", content);
                string jsonstring = await (await response).Content.ReadAsStringAsync();
                MainModel mainModel = JsonConvert.DeserializeObject<MainModel>(jsonstring);
                if (mainModel.ErrorMessage == null)
                {
                    OK.Text = "OK";

                    LentaDGV.Rows.Clear();
                    IdDel.Clear();
                    foreach (Blog blog in mainModel.Blogs)
                    {
                        string birdAll = blog.Bird + "(" + blog.BirdInLatin + ")";

                        LentaDGV.Rows.Add(blog.Id, blog.Author.Login, birdAll, blog.Time, blog.Count, blog.Place, blog.Weather, blog.Comment, blog.Picture);
                    }


                }
                else
                {
                    OK.Text = mainModel.ErrorMessage;
                }
            }
            else { OK.Text = "Необходимо авторизоваться"; };
        }

        private async void updLenta_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {

                var response = client.GetAsync("https://localhost:44381/Account/Refresh");
                string jsonstring = await (await response).Content.ReadAsStringAsync();
                MainModel mainModel = JsonConvert.DeserializeObject<MainModel>(jsonstring);
                if (mainModel.ErrorMessage == null)
                {


                    LentaDGV.Rows.Clear();
                    foreach (Blog blog in mainModel.Blogs)
                    {
                        string birdAll = blog.Bird + "(" + blog.BirdInLatin + ")";

                        LentaDGV.Rows.Add(blog.Id, blog.Author.Login, birdAll, blog.Time, blog.Count, blog.Place, blog.Weather, blog.Comment, blog.Picture);
                    }
                }
            }
            else { OK.Text = "Необходимо авторизоваться"; };
        }

        private async void newbl_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                int count;


                if ((nbirdn.Text != "") && (ncount.Text != "") && (nplace.Text != "") && (Int32.TryParse(ncount.Text, out count)) && (ndate.Value != null))
                {
                    /*string bird,
                                                   string birdInLatin,
                                                   int count,
                                                   DateTime time,
                                                   string weather,
                                                   string place,
                                                   string comment,
                                                   IFormFile file*/

                    MultipartFormDataContent content = new MultipartFormDataContent();
                    content.Add(new StringContent(nbirdn.Text), "bird");
                    content.Add(new StringContent(nbirdlat.Text), "birdInLatin");
                    content.Add(new StringContent(ndate.Text), "time");
                    content.Add(new StringContent(nweather.Text), "weather");
                    content.Add(new StringContent(ncount.Text), "count");
                    content.Add(new StringContent(nplace.Text), "place");
                    content.Add(new StringContent(ncomment.Text), "comment");
                    var response = client.PostAsync("https://localhost:44381/Account/RegisterBlog2", content);
                    string jsonstring = await (await response).Content.ReadAsStringAsync();
                    MainModel mainModel = JsonConvert.DeserializeObject<MainModel>(jsonstring);
                    if (mainModel.ErrorMessage == null)
                    {
                        OK.Text = "Добавлено наблюдение";
                        nbirdn.Clear();
                        nbirdlat.Clear();
                        nplace.Clear();
                        nweather.Clear();
                        ncomment.Clear();
                        ncount.Clear();
                        //textBox9.Text = mainModel.Balance.ToString();
                        foreach (Blog blog in mainModel.Blogs)
                        {
                            string birdAll = blog.Bird + "(" + blog.BirdInLatin + ")";

                            LentaDGV.Rows.Add(blog.Id, blog.Author.Login, birdAll, blog.Time, blog.Count, blog.Place, blog.Weather, blog.Comment, blog.Picture);
                        }

                    }
                    else
                    {
                        OK.Text = mainModel.ErrorMessage;
                    }
                }
                else { OK.Text = "Данные введены неверно"; };
            }
            else { OK.Text = "Необходимо авторизоваться"; };
        }
    }
    }

