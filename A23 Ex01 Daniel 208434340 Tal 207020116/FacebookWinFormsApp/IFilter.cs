namespace BasicFacebookFeatures
{
    public interface IFilter<T>
    {
        bool FilterBy(T obj);
    }
}
