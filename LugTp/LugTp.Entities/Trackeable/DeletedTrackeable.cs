using ConsoleApp9.Trackeable;

namespace ConsoleApp9
{
    public class DeletedTrackeable<TEntity> : BaseTrackeable<TEntity>
    {
        public DeletedTrackeable(TEntity entity) : base(entity)
        {
        }
    }
}