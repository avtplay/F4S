using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projet.Models
{
    public class UtilisateurManager : UserManager<Utilisateur>
    {

        public UtilisateurManager(IUserStore<Utilisateur> store):
            base(store)
        {
        }

        // this method is called by Owin therefore this is the best place to configure your User Manager
        public static UtilisateurManager Create(
            IdentityFactoryOptions<UtilisateurManager> options, IOwinContext context)
        {
            var manager = new UtilisateurManager(
                new UserStore<Utilisateur>(context.Get<MyDbContext>()));

            // optionally configure your manager
            // ...

            return manager;
        }
    }
}
