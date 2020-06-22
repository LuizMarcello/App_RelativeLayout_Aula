using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_RelativeLayout_Aula
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RelativeLayoutPage : ContentPage
    {
        public RelativeLayoutPage()
        {
            InitializeComponent();

            var layout = new RelativeLayout();

            var box1 = new BoxView { Color = Color.Lime };

            var box2 = new BoxView { Color = Color.Purple };

            layout.Children.Add(box1,

                widthConstraint: Constraint.RelativeToParent(p => p.Width),

                heightConstraint: Constraint.RelativeToParent(p => p.Height * .25));

            layout.Children.Add(box2,

                yConstraint: Constraint.RelativeToView(box1, (RelativeLayout, b1) => b1.Height + 50));

            Content = layout;

                
        }
    }
}
