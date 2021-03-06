﻿using System;
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

namespace Duck_Hunt_1._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Duck duck = new Duck();
        MediaPlayer musicPlayer = new MediaPlayer();

        System.Windows.Threading.DispatcherTimer gameTimer = new System.Windows.Threading.DispatcherTimer();
        int counter = 0;

        public MainWindow()
        {
            InitializeComponent();

            gameTimer.Tick += GameTimer_Tick;
            gameTimer.Interval = new TimeSpan(0, 0, 0, 0, 1000 / 60);//fps
            gameTimer.Start();
            //start music
            //musicPlayer.Open(new Uri("tapperSong.mp3", UriKind.Relative));
            //musicPlayer.Play();
            duck.Spawn();

            Canvas.Children.Add(duck.duck);
            duck.Move(counter);
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            counter++;
            //this.Title = counter.ToString();
            duck.Move(counter);
        }
    }
}
