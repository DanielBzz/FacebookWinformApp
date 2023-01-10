using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    internal class CollectionFormFactory
    {
        public static Form CreateForm(User i_LoggedInUser, eCollectionFormType i_FormType)
        {
            Form form;

            switch (i_FormType)
            {
                case eCollectionFormType.FriendsForm:
                    form = new FormFacebookCollection<User>(i_LoggedInUser.Friends);
                    ((FormFacebookCollection<User>)form).DescriptionDataBinding("About");
                    ((FormFacebookCollection<User>)form).MainPhotoDataBinding("ImageNormal");
                    break;
                case eCollectionFormType.GroupsForm:
                    form = new FormFacebookCollection<Group>(i_LoggedInUser.Groups);
                    ((FormFacebookCollection<Group>)form).DescriptionDataBinding("Description");
                    ((FormFacebookCollection<Group>)form).MainPhotoDataBinding("ImageNormal");
                    break;
                case eCollectionFormType.LikedPagesForm:
                    form = new FormFacebookCollection<Page>(i_LoggedInUser.LikedPages);
                    ((FormFacebookCollection<Page>)form).DescriptionDataBinding("Description");
                    ((FormFacebookCollection<Page>)form).MainPhotoDataBinding("ImageNormal");
                    break;
                case eCollectionFormType.EventsForm:
                    form = new FormFacebookCollection<Event>(i_LoggedInUser.Events);
                    ((FormFacebookCollection<Event>)form).DescriptionDataBinding("Description");
                    ((FormFacebookCollection<Event>)form).MainPhotoDataBinding("ImageNormal");
                    break;
                case eCollectionFormType.AlbumsForm:
                    form = new FormFacebookCollection<Album>(i_LoggedInUser.Albums);
                    ((FormFacebookCollection<Album>)form).DescriptionDataBinding("Description");
                    ((FormFacebookCollection<Album>)form).MainPhotoDataBinding("ImageAlbum");
                    break;
                default:
                    throw new Exception();
            }

            return form;
        }
    }
}
