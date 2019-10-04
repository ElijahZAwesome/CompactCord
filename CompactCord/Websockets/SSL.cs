using System;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto.Tls;

namespace CompactCord.Websockets
{
    [Obsolete]
    public class TrustAllCertificatePolicy : ICertificateVerifyer
    {
        public TrustAllCertificatePolicy()
        {
        }

        public bool CheckValidationResult(ServicePoint srvPoint, X509Certificate certificate, WebRequest request, int certificateProblem)
        {
            return true;
        }

        bool IsValid(X509CertificateStructure[] certs)
        {
            return true;
        }

        bool ICertificateVerifyer.IsValid(X509CertificateStructure[] certs)
        {
            return true;
        }
    }
}
