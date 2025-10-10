using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;

namespace Auth
{
    public class JwtHandler:IJwtHandler
    {
        private readonly JwtSecurityTokenHandler _jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
        private readonly JwtOptions _options;
        private readonly SecurityKey _issuerSigingKey;
        private readonly SigningCredentials _signingCredientials;
        private readonly JwtHeader _jwtHeader;
        private readonly TokenValidationParameters _tokenValidationParameters;

        public JwtHandler(IOptions<JwtOptions> jwOptions)
        {
            _options = jwOptions.Value;
            _issuerSigingKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_options.SecretKey));
            _signingCredientials = new SigningCredentials(_issuerSigingKey, SecurityAlgorithms.HmacSha256);
            _jwtHeader = new JwtHeader(_signingCredientials);
            _tokenValidationParameters = new TokenValidationParameters()
            {
                ValidateAudience = false,
                ValidIssuer = _options.Issuer,
                IssuerSigningKey = _issuerSigingKey
            };
        }


        public JsonWebToken Create(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
