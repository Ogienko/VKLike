using System.Data.Entity;

namespace VKLike.Models {

    public class VKLikeContext : DbContext {

        public VKLikeContext() : base("VKLikeConnection") { }

        public DbSet<Like> Likes { get; set; }
    }
}