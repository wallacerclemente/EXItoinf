using System;

namespace EXItoinfWallace.Modelos
{
    public class Etiqueta
    {
        private string _codigoEtiqueta;

        public string CodigoEtiqueta
        {
            get{return _codigoEtiqueta; }
            set{ _codigoEtiqueta = value;}
        }

        private string _nomeCliente;

        public string NomeCliente
        {
            get { return _nomeCliente; }
            set { _nomeCliente = value; }
        }

        private string _endereco;

        public string Endereco
        {
            get { return _endereco; }
            set { _endereco = value; }
        }

        private string _bairro;

        public string Bairro
        {
            get { return _bairro; }
            set { _bairro = value; }
        }

        private string _cidade;

        public string Cidade
        {
            get { return _cidade; }
            set { _cidade = value; }
        }

        private string _cep;

        public string Cep
        {
            get { return _cep; }
            set { _cep = value; }
        }

        private string _chaveIntegracao;

        public string ChaveIntegracao
        {
            get { return _chaveIntegracao; }
            set { _chaveIntegracao = value; }
        }

        private string _status;

        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }

        private int _id;
        
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public void Etiquetas()
        {

        }


        public void Etiquetas(string codigoEtiqueta, string nome, string endereco, string bairro, string cidade, string cep, string chaveIntegracao, string status)
        {
            this.CodigoEtiqueta = codigoEtiqueta;
            this.NomeCliente = nome;
            this.Endereco = endereco;
            this.Bairro = bairro;
            this.Cidade = cidade;
            this.Cep = cep;
            this.ChaveIntegracao = chaveIntegracao;
            this.Status = status;
        }
    }
}