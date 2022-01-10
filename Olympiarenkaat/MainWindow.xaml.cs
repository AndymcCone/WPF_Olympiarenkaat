using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Media.Animation;

namespace Olympiarenkaat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void omaCanvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DoubleAnimation a = new DoubleAnimation();
            a.From = Canvas.GetLeft(musta);
            a.To = e.GetPosition(omaCanvas).X - musta.ActualWidth / 2;
            a.Duration = new Duration(TimeSpan.Parse("0:0:0.1"));
            musta.BeginAnimation(Canvas.LeftProperty, a);

            DoubleAnimation b = new DoubleAnimation();
            b.From = Canvas.GetTop(musta);
            b.To = e.GetPosition(omaCanvas).Y - musta.ActualHeight / 2;
            b.Duration = new Duration(TimeSpan.Parse("0:0:0.1"));
            musta.BeginAnimation(Canvas.TopProperty, b);

            DoubleAnimation c = new DoubleAnimation();
            c.From = Canvas.GetLeft(oranssi);
            c.To = e.GetPosition(omaCanvas).X - oranssi.Width * 1.02;
            c.Duration = new Duration(TimeSpan.Parse("0:0:0.3"));
            oranssi.BeginAnimation(Canvas.LeftProperty, c);

            DoubleAnimation d = new DoubleAnimation();
            d.From = Canvas.GetTop(oranssi);
            d.To = e.GetPosition(omaCanvas).Y;
            d.Duration = new Duration(TimeSpan.Parse("0:0:0.3"));
            oranssi.BeginAnimation(Canvas.TopProperty, d);

            DoubleAnimation f = new DoubleAnimation();
            f.From = Canvas.GetLeft(vihrea);
            f.To = e.GetPosition(omaCanvas).X + vihrea.Width * 0.02;
            f.Duration = new Duration(TimeSpan.Parse("0:0:0.3"));
            vihrea.BeginAnimation(Canvas.LeftProperty, f);

            DoubleAnimation g = new DoubleAnimation();
            g.From = Canvas.GetTop(vihrea);
            g.To = e.GetPosition(omaCanvas).Y;
            g.Duration = new Duration(TimeSpan.Parse("0:0:0.3"));
            vihrea.BeginAnimation(Canvas.TopProperty, g);

            DoubleAnimation h = new DoubleAnimation();
            h.From = Canvas.GetLeft(sininen);
            h.To = e.GetPosition(omaCanvas).X - sininen.Width * 1.54;
            h.Duration = new Duration(TimeSpan.Parse("0:0:0.5"));
            sininen.BeginAnimation(Canvas.LeftProperty, h);

            DoubleAnimation i = new DoubleAnimation();
            i.From = Canvas.GetTop(sininen);
            i.To = e.GetPosition(omaCanvas).Y - sininen.ActualHeight / 2;
            i.Duration = new Duration(TimeSpan.Parse("0:0:0.5"));
            sininen.BeginAnimation(Canvas.TopProperty, i);

            DoubleAnimation j = new DoubleAnimation();
            j.From = Canvas.GetLeft(punainen);
            j.To = e.GetPosition(omaCanvas).X + punainen.Width * 0.54;
            j.Duration = new Duration(TimeSpan.Parse("0:0:0.5"));
            punainen.BeginAnimation(Canvas.LeftProperty, j);

            DoubleAnimation k = new DoubleAnimation();
            k.From = Canvas.GetTop(punainen);
            k.To = e.GetPosition(omaCanvas).Y - punainen.ActualHeight / 2;
            k.Duration = new Duration(TimeSpan.Parse("0:0:0.5"));
            punainen.BeginAnimation(Canvas.TopProperty, k);




        }
    }
}
