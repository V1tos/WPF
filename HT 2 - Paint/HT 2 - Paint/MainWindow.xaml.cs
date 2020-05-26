using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HT_2___Paint
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        public MainWindow()
        {
            InitializeComponent();
            rbInk.IsChecked = true;
            openFileDialog.Filter = "image(*.str) | *.str";
            saveFileDialog.Filter = "image(*.str) | *.str";
        }

        private void cbColor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string color = (cbColor.SelectedItem as Label).Content.ToString();
            ink.DefaultDrawingAttributes.Color = (Color)ColorConverter.ConvertFromString(color);
        }

        private void cbDrawWidth_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int width = int.Parse((cbDrawWidth.SelectedItem as Label).Content.ToString());
            ink.DefaultDrawingAttributes.Width = width;
        }

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            if (openFileDialog.ShowDialog() == true)
            {
                StrokeCollection strokes = new StrokeCollection(new FileStream(openFileDialog.FileName, FileMode.Open));
                ink.Strokes = strokes;
            }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (saveFileDialog.ShowDialog() == true)
                ink.Strokes.Save(new FileStream(saveFileDialog.FileName, FileMode.Create));
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            ink.Strokes.Clear();
        }

        private void Erase_Checked(object sender, RoutedEventArgs e)
        {
            ink.EditingMode = InkCanvasEditingMode.EraseByStroke;
        }

        private void Gesture_Checked(object sender, RoutedEventArgs e)
        {
            ink.EditingMode = InkCanvasEditingMode.GestureOnly;
        }

        private void Paint_Checked(object sender, RoutedEventArgs e)
        {
            ink.EditingMode = InkCanvasEditingMode.Ink;
        }

        private void Select_Checked(object sender, RoutedEventArgs e)
        {
            ink.EditingMode = InkCanvasEditingMode.Select;
        }
    }
}
