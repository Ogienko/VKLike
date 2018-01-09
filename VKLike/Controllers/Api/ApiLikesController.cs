using System.Web.Http;
using VKLike.Models;

namespace VKLike.Controllers.Api {

    [RoutePrefix("api/likes")]
    public class ApiLikesController : ApiController {

        [HttpPost]
        [Route("add/")]
        public IHttpActionResult Add(AddLikeRequest addLikeRequest) {

            using (var context = new VKLikeContext()) {
                context.Likes.Add(new Like {
                    DateTime = addLikeRequest.DateTime,
                    Page = addLikeRequest.Page
                });
                context.SaveChanges();
            }

            return Ok();
        }
    }
}