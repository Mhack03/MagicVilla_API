﻿using Asp.Versioning;
using AutoMapper;
using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Models.Dto;
using MagicVilla_VillaAPI.Repository.IRepository;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace MagicVilla_VillaAPI.Controllers.v2
{
    [Route("api/v{version:apiVersion}/VillaNumberAPI")]
    [ApiController]
    [ApiVersion("2.0")]
    public class VillaNumberAPIController(IVillaNumberRepository dbVillaNumber, IMapper mapper, IVillaRepository dbVilla) : ControllerBase
    {
        protected APIResponse _response = new();
        private readonly IVillaNumberRepository _dbVillaNumber = dbVillaNumber;
        private readonly IVillaRepository _dbVilla = dbVilla;
        private readonly IMapper _mapper = mapper;

        [HttpGet("GetString")]
        public IEnumerable<string> Get() => ["Mark Antony", "Web API Demo"];

    }
}
