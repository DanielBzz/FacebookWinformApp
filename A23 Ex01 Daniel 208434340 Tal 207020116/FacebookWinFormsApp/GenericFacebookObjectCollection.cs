using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class GenericFacebookObjectCollection<T> : IEnumerable<T>
    {
        private readonly FacebookObjectCollection<T> r_FullCollection;

        public IFilter<T> Strategy { get; set; }

        public GenericFacebookObjectCollection(FacebookObjectCollection<T> i_Collection)
        {
            r_FullCollection = i_Collection;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in r_FullCollection)
            {
                if (Strategy == null || Strategy.FilterBy(item))
                {
                    yield return item;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
