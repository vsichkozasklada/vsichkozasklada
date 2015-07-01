using SportSystem.Common.Mappings;
using SportSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SportSystem.Web.ViewModels
{
    public class CommentViewModel : IMapFrom<Comment>
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public DateTime CommentDate { get; set; }

        public string User { get; set; }

        public int MatchId { get; set; }
        
        public void CreateMappings(AutoMapper.IConfiguration configuration)
        {
            configuration.CreateMap<Comment, CommentViewModel>()
                .ForMember(x => x.User, cnf => cnf.MapFrom(m => m.User.UserName));
        }
    }
}
