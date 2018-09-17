using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Models.Domain;
using MVC_Introduction.Models;
using Repo;

namespace MVC_Introduction.Services
{
    public class UserService : IUserService
    {

        private IRepository _repository;
        public UserService(IRepository repository)
        {
            _repository = repository;
        }

        public IList<GetUsersViewModel> GetUsers()
        {
            var users = _repository.GetAll<User>().ToList();

            return Mapper.Map<IList<User>, IList<GetUsersViewModel>>(users);
        }
    }
}