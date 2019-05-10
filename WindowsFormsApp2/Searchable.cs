using System;
using System.Linq;

namespace WindowsFormsApp2{
    public class Searchable{
        public virtual Boolean MyContains(object instance, String word){
            return instance.GetType()
                   .GetProperties()
                   .Where(x => x.PropertyType == typeof(String))
                   .Select(x => (String)x.GetValue(instance, null))
                   .Where(x => x != null)
                   .Any(x => x.IndexOf(word, StringComparison.CurrentCultureIgnoreCase) >= 0);
        }
    }
}
