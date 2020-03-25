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
using ManualDataBinding.Data;

namespace ManualDataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // create a new not to add to editor
        Note note = new Note();

        public MainWindow()
        {
            InitializeComponent();
            Editor.Note = note;
        }
        /// <summary>
        /// handler to creane a new note and place it in the editor
        /// </summary>
        /// <param name="sender"> button clicked </param>
        /// <param name="e"> event args </param>
        public void OnNewNote (object sender, RoutedEventArgs e)
        {
            note = new Note();
            Editor.Note = note;

        }
        /// <summary>
        /// event handler for Clear note button
        /// </summary>
        /// <param name="sender"> button clicked </param>
        /// <param name="e"> event args </param>
        public void OnClearNote (object sender, RoutedEventArgs e)
        {
            note.Body = "";

        }
        /// <summary>
        /// handler to mutate the current note 
        /// </summary>
        /// <param name="sender"> button clicked </param>
        /// <param name="e"> event args </param>
        public void OnMutateNote (object sender, RoutedEventArgs e)
        {
            note.Title = "M. Gustave H.";
            note.Body = "Rudeness is merely the expression of fear. People fear they won't get what they want. The most dreadful and unattractive person only needs to be loved and they will open up like a flower.";

        }
    }
}
