using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Practical_2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            DateTime dob = new DateTime(2000, 10, 13);
            Student s1 = new Student(1, "John Tan", "88552211", dob);
            Student s2 = new Student(2, "Fel", "88552211", dob);
            Student s3 = new Student(3, "sua", "88552211", dob);
            Student s4 = new Student(4, "jo", "88552211", dob);
            Student s5 = new Student(5, "xuan", "88552211", dob);



            //Question 2

            s1Text.Text = string.Format("Id={0}, Name={1}", s1._id.ToString(), s1._name);
            s2Text.Text = string.Format("Id={0}, Name={1}", s2._id.ToString(), s2._name);
            s3Text.Text = string.Format("Id={0}, Name={1}", s3._id.ToString(), s3._name);
            s4Text.Text = string.Format("Id={0}, Name={1}", s4._id.ToString(), s4._name);
            s5Text.Text = string.Format("Id={0}, Name={1}", s5._id.ToString(), s5._name);

            //create a student object List
            List<Student> studentList = new List<Student>();

            //put 5 numbers into the list
            for (int i = 0; i < 6; i++) 
            {
                studentList.Add(s1);
                studentList.Add(s2);
                studentList.Add(s3);
                studentList.Add(s4);
                studentList.Add(s5);
            }



        }
    }
}
