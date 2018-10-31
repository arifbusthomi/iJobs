using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using WebApiService.Repository;

namespace WebApiService.Controllers
{
    public class CandidateController : ApiController
    {
        [HttpGet]
        public JsonResult<List<Models.Candidate>> GetAllCandidate()
        {
            EntityMapper<dal.Tbl_Candidate, Models.Candidate> mapObj = new EntityMapper<dal.Tbl_Candidate, Models.Candidate>();

            List<dal.Tbl_Candidate> candList = dal.DAL.GetAllCandidate();
            List<Models.Candidate> candidate = new List<Models.Candidate>();
            foreach (var item in candList)
            {
                candidate.Add(mapObj.Translate(item));
            }
            return Json<List<Models.Candidate>>(candidate);
        }

        [HttpGet]
        public JsonResult<Models.Candidate> GetCandidate(int id)
        {
            EntityMapper<dal.Tbl_Candidate, Models.Candidate> mapObj = new EntityMapper<dal.Tbl_Candidate, Models.Candidate>();
            dal.Tbl_Candidate dalCandidate = dal.DAL.GetCandidate(id);
            Models.Candidate candidate = new Models.Candidate();
            candidate = mapObj.Translate(dalCandidate);
            return Json<Models.Candidate>(candidate);
        }
        [HttpPost]
        public bool InsertProduct(Models.Candidate candidate)
        {
            bool status = false;
            if (ModelState.IsValid)
            {
                EntityMapper<Models.Candidate, dal.Tbl_Candidate> mapObj = new EntityMapper<Models.Candidate, dal.Tbl_Candidate>();
                dal.Tbl_Candidate candidateObj = new dal.Tbl_Candidate();
                candidateObj = mapObj.Translate(candidate);
                status = dal.DAL.InsertCandidate(candidateObj);
            }
            return status;

        }
        [HttpPut]
        public bool UpdateProduct(Models.Candidate candidate)
        {
            EntityMapper<Models.Candidate, dal.Tbl_Candidate> mapObj = new EntityMapper<Models.Candidate, dal.Tbl_Candidate>();
            dal.Tbl_Candidate candidateObj = new dal.Tbl_Candidate();
            candidateObj = mapObj.Translate(candidate);
            var status = dal.DAL.UpdateCandidate(candidateObj);
            return status;

        }
        [HttpDelete]
        public bool DeleteProduct(int id)
        {
            var status = dal.DAL.DeleteCandidate(id);
            return status;
        }
    }
}
