using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using Info.Data;

namespace Info
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadAuditoriums();
        }

        private void LoadAuditoriums()
        {
            using (var context = new AppDbContext())
            {
                List<string> auditoriums = context.Auditoriums
                    .Where(a => a.Floor == 5)
                    .ToList()
                    .OrderBy(a => int.Parse(a.Name.Split(" - ")[0]))
                    .Select(a => a.Name)
                    .ToList();
                AuditoriumsListBox.ItemsSource = auditoriums;
            }
        }
    }
}