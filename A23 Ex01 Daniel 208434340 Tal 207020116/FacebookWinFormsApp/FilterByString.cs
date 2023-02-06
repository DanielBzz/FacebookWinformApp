using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class FilterByString<T> : IFilter<T>
    {
        private string m_SubName;

        public FilterByString(string i_SubStr)
        {
            m_SubName = i_SubStr;
        }

        public bool FilterBy(T obj)
        {
            PropertyInfo nameProperty = typeof(T).GetProperty("Name");
            string currentName = nameProperty.GetValue(obj) is string ?
                        nameProperty.GetValue(obj) as string : $"No Name for {typeof(T)}";

            return currentName != null && currentName.ToUpper().Contains(m_SubName);
        }
    }
}
