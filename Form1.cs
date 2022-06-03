using System;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using System.Windows.Forms;
using System.Diagnostics;

namespace Geo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(
                "http://free.ipwhois.io/json/" + textBox1.Text);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader sr = new StreamReader(stream);

            string sReadData = sr.ReadToEnd();
            response.Close();

            dynamic d = JsonConvert.DeserializeObject(sReadData);
            label1.Text = d.city;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RestClient client = new RestClient
                ("https://api.timepad.ru/v1/events.json?limit=20&skip=0&fields=name,location&sort=name");
           
            
            RestRequest request = new RestRequest(Method.GET);


            //request.AddHeader("content-type", "application/x-www-form-urlencoded");

            request.AddHeader("Authorization", "Bearer b1d6474665c596700f288521758c76c23b106fd0");


            IRestResponse response = client.Execute(request);

            string stream = response.Content;

            dynamic d = JsonConvert.DeserializeObject(stream);

            try
            {
                label2.Text = d.ToString();//.location.value;
            }
            catch(Exception ex) 
            {
                Debug.WriteLine("[ex] Exception: " + ex.Message);
            }
        }
    }
}
