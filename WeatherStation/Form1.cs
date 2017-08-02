using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

namespace WeatherStation
{
    public partial class formLiveValue : Form
    {

        private SerialPort meteo;
        private string Time;
        
        private char[] buffer;
        private int index;
        public delegate void PrintString(String data);
        private PrintString printfunction;

        private IWeatherValue sensorval;

        private double valuestation;

        private string filename;
        private string comma = ",";

        private int isopen;
        public formLiveValue()
        {
            
            InitializeComponent();
            buffer = new char[128];
            index =0;
            printfunction = new PrintString(PrintLine);

            string[] ports = SerialPort.GetPortNames(); // # aviable ports in combobox
            foreach (string port in ports)
            {
                comboBoxSerialport.Items.Add(port);
            }

            timerTime.Start();
          
        }
        
        

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxSerialport.SelectedItem != null)
                {
                    string com = comboBoxSerialport.SelectedItem.ToString();

                    meteo = new System.IO.Ports.SerialPort(com, 9600, System.IO.Ports.Parity.None, 8, System.IO.Ports.StopBits.One);
                    meteo.DataReceived += DataReceivedHandler;
                   // meteo.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler2);
                    meteo.Open();
                    isopen = 1;
                  
                }
                else
                {
                    MessageBox.Show(" select a serial port ");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       
       private enum typevalue { Humidity,Illuminace,Pressure ,Temperature}
      

        private void PrintLine(String data)
        {
            
            tBoxData.AppendText(data ); // pure data schrijven in textboxData

             /*  separate value & text */           
            string[] line = data.Split(':','\n'); // eerste lijn in array line[0]:name line[1]:value  
            if (line.Length >= 2)
            {
                
                if (line[0].Contains("humidity"))
                {
                    
                    valuestation = Convert.ToDouble(line[1]);
                    sensorval = new humiditys(valuestation);
                    tBoxHum.AppendText(Convert.ToString(sensorval.realValue()) + "%" + Environment.NewLine);
                    graphHumidity.tittle(typevalue.Humidity.ToString(),"%");
                    graphHumidity.addSensorValue(sensorval.realValue());
                }
                else if (line[0].Contains("illuminance"))
                {
                  
                    valuestation = Convert.ToDouble(line[1]);
                    sensorval = new illuminance(valuestation);
                    tBoxIll.AppendText(Convert.ToString(sensorval.realValue()) + "%"+ Environment.NewLine);
                    graphIllumine.tittle(typevalue.Illuminace.ToString(),"%");
                    graphIllumine.addSensorValue(sensorval.realValue());

                }
                else if (line[0].Contains("pressure"))
                {
                    try
                    {
                        valuestation = Convert.ToDouble(Int32.Parse(line[1], System.Globalization.NumberStyles.HexNumber));
                        sensorval = new pressure(valuestation);
                        tBoxPressure.AppendText(Convert.ToString(sensorval.realValue()) + "Pa" + Environment.NewLine);
                        graphPressure.tittle(typevalue.Pressure.ToString(),"druk(Pa)");
                        graphPressure.addSensorValue(sensorval.realValue());
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (line[0].Contains("temperature"))
                {
                  
                    valuestation = Convert.ToDouble(line[1]);
                    sensorval = new Temp(valuestation);        
                    tBoxTemp.AppendText(Convert.ToString(sensorval.realValue()) + "°C" + Environment.NewLine);
                    graphTemp.tittle(typevalue.Temperature.ToString(),"temperature(°C)"  );
                    graphTemp.addSensorValue(sensorval.realValue());
                  

                }

            }
           

            

           



            

        }
       
          
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                buffer[index] = (char)meteo.ReadByte();
                if (buffer[index] == '\n')
                {
                    if (this.InvokeRequired)
                    {
                        this.Invoke(printfunction, new object[] { new String(buffer)});
                    }
                  
                
              
                    index = 0;
                }
              
       
                else
                {
                    index++;
                }
            }
               

           

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }


        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                meteo.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            timerSave.Stop();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            comboBoxSerialport.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                comboBoxSerialport.Items.Add(port);
            }
        }

     
        private void timerTime_Tick_1(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            Time = dateTime.ToString();
            lblTime.Text = Time;
            
        }

        private void Save_Click(object sender, EventArgs e)
        {
           

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "csv File|*.csv";
            sfd.Title = " save csv file";
            filename = "";
            

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                filename = sfd.FileName;
                string path = sfd.FileName;
                StreamWriter outpustream = File.CreateText(filename);
                outpustream.WriteLine("date,time,temperature,pressure,illuminace,humidity");
                timerSave.Start();
                outpustream.Close();

               
            }
           
        }

        private void timerSave_Tick(object sender, EventArgs e)
        {
            if (isopen == 1)
            {
                try
                {
                    using (StreamWriter sw = File.AppendText(filename))
                    {
                        for (int i = 0; i < graphPressure.getvalue.Count() &&
                            i < graphHumidity.getvalue.Count() && i < graphTemp.getvalue.Count()
                            && i < graphIllumine.getvalue.Count(); i++)
                        {
                            if (i > 0)
                            {
                                string uur = DateTime.Now.ToString("H:mm:s");
                                string date = DateTime.Now.ToString("dd/MM/yyyy");

                                sw.WriteLine(date + comma + uur + comma + graphTemp.getvalue[i].ToString() + comma
                                    + graphPressure.getvalue[i].ToString() + comma +
                                    graphIllumine.getvalue[i].ToString() + comma
                                    + graphHumidity.getvalue[i].ToString());
                            }
                        }
                        sw.Close();
                    }

                }
                catch (IOException exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAppend_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new  OpenFileDialog();
            ofd.Filter = "csv files|*.csv|All Files|*.*";
            ofd.Title = " choose file ";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filename = ofd.FileName;
               string path = ofd.FileName;
               StreamWriter append = File.AppendText(filename);
                //outpustream.WriteLine("date,time,temperature,pressure,illuminace,humidity");
                timerSave.Start();
                append.Close();


            }



        }

        private void formLiveValue_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height - 41 ;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);

        }

       

        
    }
}
