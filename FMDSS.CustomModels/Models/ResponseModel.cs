using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMDSS.CustomModels.Models
{
    public static class Response
    {
        public static string ErrorLogs(string ErrorMessage, string OrderId, string Sqlrequest, string Sqlresponse, string Discorequest, string DiscoResponse, string methodName, string connectionString, int companyId)
        {
            string guid = string.Empty;
            try
            {
                // guid = SqlFeatures.InsertOrderLogEntries(connectionString, ErrorMessage, OrderId, Sqlrequest, Sqlresponse, Discorequest, DiscoResponse, methodName, DateTime.Now.ToString());

            }
            catch
            {
                // We want to silently catch exceptions adding log entries.
            }
            return guid;
        }
    }

    public enum ResponseStatus
    {
        Success = 1,
        Failed = 0
    }

    public class ResponseBase
    {
        public ResponseBase()
        {
            Status = ResponseStatus.Success;
            Message = ResponseStatus.Success.ToString();
            ErrorDescription = string.Empty;
        }

        [Required]
        public ResponseStatus Status { get; set; }

        [Required]
        public string ErrorDescription { get; set; }

        [Required]
        public string Message { get; set; }

        [Required]
        public string ErrorTransactionId { get; set; }

        public void SetStatus(ResponseBase data)
        {
            if (data != null)
            {
                Status = data.Status;
                Message = data.Message;
                ErrorDescription = data.ErrorDescription;
                ErrorTransactionId = data.ErrorTransactionId;
            }
        }
    }

    public class DataSetResponse : ResponseBase
    {
        public DataSet Data { get; set; }
    }
    public class DataTableResponse : ResponseBase
    {
        public DataTableResponse()
        {
            Data = new DataTable();
        }
        public DataTable Data { get; set; }
    }
    public class StringResponse : ResponseBase
    {
        public string Data { get; set; }
    }
    public class BooleanResponse : ResponseBase
    {
        public bool Data { get; set; }
    }
    public class IntegerResponse : ResponseBase
    {
        public int? Data { get; set; }
    }
    public class ObjectResponse : ResponseBase
    {
        public object Data { get; set; }
    }

    public class DynamicResponse : ResponseBase
    {
        public DynamicResponse()
        {
            Data = null;
        }
        public object Data { get; set; }
    }


    public class DropDownResponse:ResponseBase
    {
        public DropDownResponse()
        {
            Data = new List<DropDownValue>();
        }
        public List<DropDownValue> Data { get; set; }
    }
    public class GetDetailsResponseData : ResponseBase
    {
        public GetDetailsResponseData()
        {
            Data = new Company.GetDetailsResponse();
        }
        public Company.GetDetailsResponse Data { get; set; }
    }

    public class MasterPlaceModelResponse : ResponseBase
    {
        public MasterPlaceModelResponse()
        {
            Data = new List<Master_TblMstPlaceModel>();
        }
        public List<Master_TblMstPlaceModel> Data { get; set; }
    }
}
