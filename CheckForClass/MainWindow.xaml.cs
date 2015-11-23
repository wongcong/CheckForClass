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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using 点名系统.Plugins;

namespace 点名系统
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void bhuttonExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Drag_Move(object sender, MouseButtonEventArgs e)
            //实现拖动的一种常见方法
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        } 

        private void Icon_Animation1(Button sender, bool appear , double height ,double time)
            //图标的height动画效果，1个重载，true表示出现，false表示消失动画
            //height表示图标的高度，time表示动画时间
            //此处为button的方法
        {
            double distanceFrom,distanceTo;
            if (appear == true)
            {
                distanceFrom = 0;
                distanceTo = height;
            }
            else
            {
                distanceFrom = height;
                distanceTo = 0;
            }
            DoubleAnimation heighAnimation = new DoubleAnimation();
            heighAnimation.From = distanceFrom;
            heighAnimation.To = distanceTo;
            //线性差值需规定起点终点
            heighAnimation.Duration = TimeSpan.FromSeconds(time);
            //实现动画的时间
            sender.BeginAnimation(Button.HeightProperty, heighAnimation);
        }

        //private void Icon_Animation1(Grid sender, bool appear , double height, double time)
        //    //此处为grid的方法
        //{
        //    double distanceFrom, distanceTo;
        //    if (appear == true)
        //    {
        //        distanceFrom = 0;
        //        distanceTo = height;
        //    }
        //    else
        //    {
        //        distanceFrom = height;
        //        distanceTo = 0;
        //    }
        //    DoubleAnimation heighAnimation = new DoubleAnimation();
        //    heighAnimation.From = distanceFrom;
        //    heighAnimation.To = distanceTo;
        //    heighAnimation.Duration = TimeSpan.FromSeconds(time);
        //    sender.BeginAnimation(Grid.HeightProperty, heighAnimation);
        //}

        private ChosseCheckWay CCW;

        private void startCheck_MouseEnter(object sender, MouseEventArgs e)
        {
            CCW = new ChosseCheckWay();
            Icon_Animation1(buttonCheck, false , 150, 0.2);
            startCheck.Children.Add(CCW);
        }

        private void startCheck_MouseLeave(object sender, MouseEventArgs e)
        {
            Icon_Animation1(buttonCheck, true , 150, 0.2);
            CCW.Remove();    //这里仅仅是被隐藏了起来
        }

        private void ButtonLoad(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            Icon_Animation1(button, true , button.ActualHeight, 0.3);
        }
    }
}
