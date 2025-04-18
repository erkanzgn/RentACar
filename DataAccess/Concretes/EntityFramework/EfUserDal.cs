﻿using Core.DataAccess.EntityFramework;
using Core.Entities.Concretes;
using DataAccess.Abstract;
using Entites.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, RecapDataContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using(var context =new RecapDataContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                             on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.Id
                             select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                return result.ToList();
            }
        }
    }
}
