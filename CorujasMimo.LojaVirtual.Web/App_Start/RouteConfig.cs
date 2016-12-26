﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using System.Web.Mvc;
using System.Web.Routing;
using CorujasMimo.LojaVirtual.Web.Models;


namespace CorujasMimo.LojaVirtual.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // 1 - Início
            routes.MapRoute(null,
                "Pagina{pagina}",
                    new { controller = "Vitrine"
                        , action = "ListaProdutos"
                        , categoria = (string)null
                        , pagina = 1
                    }
            );

            // 2 - 
            routes.MapRoute(null,
                "Pagina{pagina}",
                    new { controller = "Vitrine"
                        , action = "ListaProdutos"
                        , categoria = (string)null}
                        , new { pagina = @"\d+" }
            );

            // 3 -
            routes.MapRoute(null, 
                "{categoria}", 
                    new { controller = "Vitrine"
                        , action = "ListaProdutos"
                        , pagina = 1}
            );

            // 4 -

            routes.MapRoute(null,
                "{categoria}Pagina{pagina}",
                    new { controller = "Vitrine"
                        , action = "ListaProdutos"} 
                        , new { pagina = @"\d+" }
            );

            routes.MapRoute(null, "{controller}/{action}");

            
                        routes.MapRoute(
                            name: "Default",
                            url: "{controller}/{action}/{id}",
                            defaults: new { controller = "Vitrine"
                                            , action = "ListaProdutos"
                                            , id = UrlParameter.Optional}
                        );

                        routes.MapRoute(null,
                            "Pagina{pagina}",
                                new { controller = "Vitrine"
                                    , Action = "ListaProdutos"
                                    , categoria = (string) null}
                                    , new { Paginacao = @"\d+"}
                        );
             
             
        }
    }
}
