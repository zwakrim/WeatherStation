using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;


namespace WeatherStation
{
   public partial class GraphUserControl : UserControl
    {
       private int x_, y_;
       private double[,] graph;
       
       private List<double> listSensorValues;
       private Pen pen;
       private Pen pens;

       double maxValue_;
      
       public GraphUserControl()
       {
          
           this.x_ = base.Width;
           this.y_ = base.Height;

           this.graph = new double[x_, y_];
           base.Paint += this.OnPaint;
           this.SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.DoubleBuffer,
                true);
           listSensorValues = new List<double>();
       }

       public void addSensorValue(double value)
       {
           try
           {
               listSensorValues.Add(value);
           }
           catch(Exception ex)
           {
               MessageBox.Show(ex.Message);
           }
           updateGraph();
       }
       public void updateGraph()
       {
           base.Refresh();
       }
       
       private void updateGraphIntern(Graphics paper)
       {
           paper.Clear(Color.Black);         
           Assen(paper);
           pens = new Pen(Color.Red);
           maxValue();
           if (listSensorValues.Count > 1)
           {
               for (int i = 1; i < listSensorValues.Count() - 1; i++)
               {
                   double valueY_ = (this.Height - 20)/maxValue_;

                   //int valueY = Convert.ToInt32(valueY_);
                   paper.DrawLine(pens, 30 + (i - 1),Height-((int)(valueY_*listSensorValues[i - 1]+20)), 30 + i, Height- (int)((valueY_ * listSensorValues[i])+20));

               }
           }
           //maxValue();
           //Label maxvalue = new Label();
           //maxvalue.BackColor = Color.Transparent;
           //maxvalue.ForeColor = Color.White;
           //maxvalue.Enabled = true;
           //maxvalue.Location = new Point(Width - 150 , 5);
           //maxvalue.Text = "maxvalue is :" + Convert.ToString(maxValue_);
           //this.Controls.Add(maxvalue);
       }
       private void maxValue()
       {
           for (int i = 0; i < listSensorValues.Count; i++)
           {
               if(listSensorValues.Count == 0)
               {
                   maxValue_ =listSensorValues[0];
               }
               if(listSensorValues[i]> maxValue_)
               {
                   maxValue_ =listSensorValues[i];
               }
               

           }
       }
  
       private void Assen(Graphics pap)
       {
           /* xas label */
           Label xas = new Label();
           xas.Text = " Time";
           xas.BackColor = Color.Transparent;
           xas.ForeColor = Color.White;
           xas.Enabled = true;
           xas.Location = new Point(Width / 2, Height -15);
           this.Controls.Add(xas);
           
           pen = new Pen(Color.White, 3);
           pen.EndCap = LineCap.ArrowAnchor; // pijl op einde van as
           pen.StartCap = LineCap.Square;
           pap.DrawLine(pen, 30, Height - 20, Width - 10, Height - 20); // xas
           pap.DrawLine(pen, 30, Height - 20, 30, Height -150); //yas


       }
       private void OnPaint(object sender, PaintEventArgs e)
       {
           updateGraphIntern(e.Graphics);
       }
       public void tittle( string Tittle, string yas)
       {
           Label tittle = new Label();
           tittle.BackColor = Color.Transparent;
           tittle.ForeColor = Color.White;
           tittle.Enabled = true;
           tittle.Location = new Point(Width / 2, 5);
           tittle.Text = Tittle;
           this.Controls.Add(tittle);

           Label yTittle = new Label();
           yTittle.BackColor = Color.Transparent;
           yTittle.ForeColor = Color.Red;
           yTittle.Enabled = true;
           yTittle.Text = yas;
           yTittle.Location = new Point(15, 5);
           this.Controls.Add(yTittle);

       }
        public List<double> getvalue
       {
           get { return this.listSensorValues;}
       }

    }
}
