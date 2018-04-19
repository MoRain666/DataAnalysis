using System;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Win32;
using System.IO;
using Services;
using Storage;

namespace DataAnalysis
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }
        
        private void btnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                txtEditor.Text = openFileDialog.FileName;
                if(!Reader.ReadTxtFileToTemp(openFileDialog.FileName))
                {
                    MessageBox.Show("Выберите другой файл!");
                }
                if (Temp.getTempStringArrayOfEnergy() != null)
                {
                    txtTempEnergy.Text = Temp.getTempStringArrayOfEnergy()[0];
                    txtTest.Text = string.Join(Environment.NewLine,Services.Parser.ParseString(Temp.getTempStringArrayOfEnergy()[0]));
                }
                if(Temp.getTempStringArrayOfTemperature()!=null)
                {
                    txtTempTemperature.Text = Temp.getTempStringArrayOfTemperature()[0];
                }               
            }
                
        }

        private void btnSaveAsBin_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnClearTemp_Click(object sender, RoutedEventArgs e)
        {
            Temp.setTempStringArrayOfEnergy(null);
            Temp.setTempStringArrayOfTemperature(null);
        }
    }
}