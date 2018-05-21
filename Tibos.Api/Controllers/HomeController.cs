﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Tibos.Confing.autofac;
using Tibos.ConfingModel;
using Tibos.ConfingModel.model;
using Tibos.Domain;
using Tibos.Service;
using Tibos.Service.Contract;
namespace Tibos.Api.Controllers
{
    [Route("api/[controller]")]
    public class HomeController : Controller
    {

        public UsersIService _UsersService { get; set; }

        

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var config = JsonConfigurationHelper.GetAppSettings<ManageConfig>("ManageConfig.json", "ManageConfig");
            //Users m_user = new Users();
            //m_user.user_name = "这是测试哦";
            //_UsersService.Save(m_user);
            var res = _UsersService.Get(1);
            return new string[] { res.id.ToString(), res.user_name };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<string> Get(int id)
        {
            return await Task.Run<string>(()=> {return Test(); });
        }

        private string Test()
        {
            return "666";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {

        }



    }



   

}
