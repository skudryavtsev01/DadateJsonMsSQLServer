using Dadata;
using Dadata.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DadateJsonMsSQLServer
{
    public partial class Form1 : Form
    {
        ModelDb modelDb; 
        List<Data> dataList = null; //Для временного хранения коллекции объектов.
        Data data = null; //Для хранения 1 элемента.
        Client client = null; //Для работы с контекстом.

        public Form1()
        {
            InitializeComponent();
            modelDb = new ModelDb();//Создаем экземпляр контекса
            dataList = new List<Data>();
        }

        private void buttonGetEmailDB_Click(object sender, EventArgs e)
        {
            try //обработка исключений, если упадет узнаем почему.
            {
                listBoxRows.Items.Clear(); //Удаляем все значения из ListBox
                var emailList = modelDb.Client.Select(c => c.Email); //Получить только Email
                foreach (var item in emailList)
                {
                    listBoxRows.Items.Add(item);
                }

                MessageBox.Show("Данные загружены!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // На всякий случай если упадет.
            }
        }

        private void buttonSubmitDadata_Click(object sender, EventArgs e)
        {
            List<Client> clientList = modelDb.Client.ToList();

            clientList.ForEach(item =>{dataList.Add(new Data { id = item.Id, OldData = item.Email, NewData=item.Email});}); //ШАГ 3

            var api = new CleanClient("7868dd299cace51f81edef339d7c4dd0bdeb0212", "b14a16a5e346cc9a853bcde62a6e55afb86fe2fb");

            foreach (var item in clientList.Select(c=>c.Email))
            {
                var dadata = api.Clean<Email>(item);
                if (dadata.email != null) //Чтобы убрать не читаемые данные иначе Exception
                {
                    checkedListBoxRowsDadata.Items.Add(dadata.email, (dadata.qc == "4"));
                    data = dataList.Where(c => c.OldData.Contains(item)).First(); // ШАГ 3
                    if (dataList.Remove(data)) { dataList.Add(new Data { id = data.id, OldData = data.OldData, NewData = dadata.email }); } // ШАГ 3
                }
            }
        }

        private void buttonUpdateRows_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in dataList)
                {
                    if (item.OldData != item.NewData)
                    {
                        client = modelDb.Client.Where(c => c.Id == item.id).FirstOrDefault(); //Получаем нужную строку
                        client.Email = item.NewData; //Вносим изменения
                        modelDb.SaveChanges(); // Отправляем изменения в БД.
                    }
                }

                MessageBox.Show("Изменения внесены!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
