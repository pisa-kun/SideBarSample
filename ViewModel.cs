using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace sample
{
    public class ViewModel : BindableBase
    {
        private bool isButtonA = false;
        public bool IsButtonA
        {
            get { return this.isButtonA; }
            set { this.SetProperty(ref this.isButtonA, value); }
        }

        private bool isButtonB = false;
        public bool IsButtonB
        {
            get { return this.isButtonB; }
            set { this.SetProperty(ref this.isButtonB, value); }
        }
        
        public DelegateCommand ButtonCommandA { get; private set; }
        public DelegateCommand ButtonCommandB { get; private set; }

        public ViewModel()
        {
            ButtonCommandA = new DelegateCommand(() => {
                MessageBox.Show($"ButtonA is [{IsButtonA}] state");
                IsButtonA = true;
                IsButtonB = false;
            });

            ButtonCommandB = new DelegateCommand(() => {
                MessageBox.Show($"ButtonB is [{IsButtonB}] state");
                IsButtonA = false;
                IsButtonB = true;
            });
        }
    }
}
