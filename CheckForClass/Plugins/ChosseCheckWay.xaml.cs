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

namespace 点名系统.Plugins
{
    /// <summary>
    /// ChosseCheckWay.xaml 的交互逻辑
    /// </summary>
    public partial class ChosseCheckWay : UserControl
    {
        public ChosseCheckWay()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            TranslateTransform ttup = new TranslateTransform();
            TranslateTransform ttdown = new TranslateTransform();
            DoubleAnimation up = new DoubleAnimation();
            DoubleAnimation down = new DoubleAnimation();
            //动画时间
            Duration duration = new Duration(TimeSpan.FromSeconds(0.2));
            //设置按钮的转换效果
            buttonInOrder.RenderTransform = ttup;
            buttonRandom.RenderTransform = ttdown;
            ttup.Y = 0;
            ttdown.Y = 0;
            up.To = 74;
            down.To = -74;
            up.Duration = duration;
            down.Duration = duration;
            //开始动画
            ttup.BeginAnimation(TranslateTransform.YProperty, up);
            ttdown.BeginAnimation(TranslateTransform.YProperty, down);

            //这种方法会使得两个元素有先后执行的弊端，后期可改进
        }

        public void Remove()
        {
            TranslateTransform ttup = new TranslateTransform();
            TranslateTransform ttdown = new TranslateTransform();
            DoubleAnimation up = new DoubleAnimation();
            DoubleAnimation down = new DoubleAnimation();
            //动画时间
            Duration duration = new Duration(TimeSpan.FromSeconds(0.2));
            //设置按钮的转换效果
            buttonInOrder.RenderTransform = ttup;
            buttonRandom.RenderTransform = ttdown;
            ttup.Y = 74;
            ttdown.Y = -74;
            up.To = -74;
            down.To = 74;
            up.Duration = duration;
            down.Duration = duration;
            //开始动画
            ttup.BeginAnimation(TranslateTransform.YProperty, up);
            ttdown.BeginAnimation(TranslateTransform.YProperty, down);
        }

        private void buttonInOrder_Click(object sender, RoutedEventArgs e)
        {
            CheckWindow checkInOrder = new CheckWindow();
            checkInOrder.ShowDialog();
        }

        private void buttonRandom_Click(object sender, RoutedEventArgs e)
        {
            CheckWindow checkRandom = new CheckWindow();
            checkRandom.ShowDialog();
        }
    }
}
