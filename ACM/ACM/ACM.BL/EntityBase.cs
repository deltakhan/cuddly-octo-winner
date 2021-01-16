using System;
namespace ACM.BL
{
    public abstract class EntityBase
    {
        public EntityBase()
        {
        }

        public enum EntityStateOption
        {
            Active,
            Delete
        }

        public EntityStateOption EntityState { get; set; }
        public bool HasChanges { get; set; }
        public bool IsNew { get; private set; }
        public bool IsValid => Validate();

        public abstract bool Validate();
    }
}
