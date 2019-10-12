using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace P1
{
    class Brain
    {
       
    }

    public static class VisualTreeHelperExtensions
    {
        public static T FindAncestor<T>(DependencyObject dependencyObject)
            where T : class
        {
            DependencyObject target = dependencyObject;
            do
            {
                target = System.Windows.Media.VisualTreeHelper.GetParent(target);
            }
            while (target != null && !(target is T));
            return target as T;
        }

    }
}
