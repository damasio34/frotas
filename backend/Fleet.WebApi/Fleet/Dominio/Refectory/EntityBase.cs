using System;
using System.Linq;

namespace Kereta.Dominio.Refectory
{
    public static class EntityBaseExtension
    {
        public static bool IsNullOrTransient(this EntityBase entity)
        {
            return entity == null || entity.IsTransient;
        }

        public static void ThrowIsNullOrTransient(this EntityBase entity)
        {
            if (entity == null)
                throw new ArgumentNullException();

            if (entity.Id.Equals(Guid.Empty))
                throw new ArgumentException();
        }

        public static T GenerateIdentityAndReturn<T>(this T entity)
            where T:EntityBase
        {
            entity.GenerateNewIdentity();
            return entity;
        }

        public static T ChangeIdentityAndReturn<T>(this T entity, Guid id)
            where T : EntityBase
        {
            entity.ChangeIdentity(id);
            return entity;
        }

        public static T ChangeIdentityAndReturn<T>(this T entity, string id)
            where T : EntityBase
        {
            return entity.ChangeIdentityAndReturn(Guid.Parse(id));
        }
    }
    public class EntityBase
    {
        protected void ThrowIsNullOrTransient(params EntityBase[] entidades)
        {
            entidades.ToList().ForEach(s=>s.ThrowIsNullOrTransient());
        }

        public Guid Id { get; private set; }

        public void GenerateNewIdentity()
        {
            Id = Guid.NewGuid();
        }

        public bool IsTransient
        {
            get { return Id.Equals(Guid.Empty); }
        }

        public void ChangeIdentity(Guid id)
        {
            Id = id;
        }

    }
}
