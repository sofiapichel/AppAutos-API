using ABM.AppAutos.BE.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;
using AutoMapper;
using ABM.AppAutos.BE.Repositories.UoW;
using Microsoft.Extensions.Logging;
using ABM.AppAutos.BE.Services.Interfaces;

namespace ABM.AppAutos.BE.Services.Implements
{
    public class AuthService : IAuthService
    {
        #region Dependencias
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<AuthService> _logger;
        #endregion

        #region Constructor
        public AuthService(
            IUnitOfWork unitOfWork,
            IMapper mapper,
            ILogger<AuthService> logger
            )
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public Task<LoginResponseDTO> ActiveDirectoryAuthenticate(LoginRequestDTO model)
        {
            throw new NotImplementedException();
        }

        public Task<LoginResponseDTO> Login(LoginRequestDTO model)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Metodos

        //public async Task<LoginResponseDTO> Login(LoginRequestDTO model)
        //{
        //    var colaborador = await _unitOfWork.Colaboradores.GetByEmail(model.Email);

        //    if (colaborador == null)
        //        return null;

        //    var credencial = await _unitOfWork.Credenciales.GetByColaborador(colaborador.Id);

        //    if (credencial == null)
        //        return null;

        //    //DESCOMENTAR CUANDO ESTE EL ABM DE USUARIOS Y SE GUARDE LA PASSWORD ENCRIPTADA!
        //    //bool passwordCorrecto = HelperCryptography.CompareEncryptPassword(model.password, usuario.Password);
        //    bool passwordCorrecto = model.Password.ToLower() == credencial.Password.ToLower();

        //    if (!passwordCorrecto)
        //        return null;

        //    LoginResponseDTO response = new LoginResponseDTO()
        //    {
        //        Email = colaborador.Email ?? "",
        //        NombreCompleto = colaborador.Nombre + " " + colaborador.Apellido,
        //        UserName = colaborador.Id.ToString()
        //    };

        //    return response;
        //}


        //public async Task<LoginResponseDTO> ActiveDirectoryAuthenticate(LoginRequestDTO model)
        //{
        //    var domain = "SMSARGENTINA\\";

        //    using (System.DirectoryServices.DirectoryEntry _entry = new System.DirectoryServices.DirectoryEntry())
        //    {
        //        _entry.Username = domain + model.Email;
        //        _entry.Password = model.Password;
        //        DirectorySearcher _searcher = new DirectorySearcher(_entry);
        //        _searcher.Filter = "(&(objectClass=user)(anr=" + model.Email + "))";
        //        _searcher.PropertiesToLoad.Add("givenName");   // first name
        //        _searcher.PropertiesToLoad.Add("sn");          // last name
        //        _searcher.PropertiesToLoad.Add("mail");        // smtp mail address

        //        try
        //        {
        //            SearchResult _sr = _searcher.FindOne();
        //            string _name = _sr.Properties["givenName"][0].ToString();

        //            List<string> grupos = GetAdGroupsForUser2(model);

        //            return new LoginResponseDTO()
        //            {
        //                UserName = model.Email,
        //                Email = _sr.Properties["mail"][0].ToString(),
        //                NombreCompleto = _sr.Properties["givenName"][0].ToString() + " " +
        //                  _sr.Properties["sn"][0].ToString(),
        //                Grupos = grupos
        //            };

        //        }
        //        catch
        //        { /* Error handling omitted to keep code short: remember to handle exceptions !*/ }
        //    }

        //    return null; //true = user authenticated!
        //}




        #endregion
    }
}
