﻿namespace ShopAPI.Response
{
    public class ResponseHandler
    {
        public static ApiResponse GetExceptionResponse(Exception ex)
        {
            ApiResponse response = new ApiResponse();
            response.Code = "1";
            response.ResponseData = ex.Message;
            return response;
        }
        public static ApiResponse GetApiResponse(ResponseType type, object? contract)
        {
            ApiResponse response;

            response = new ApiResponse { ResponseData = contract };
            switch (type)
            {
                case ResponseType.Success:
                    response.Code = "0";
                    response.Message = "Success";
                    break;
                case ResponseType.AlreadyExist:
                    response.Code = "3";
                    response.Message = "object already exist";
                    break;
                case ResponseType.NotFound:
                    response.Code = "2";
                    response.Message = "No object available";
                    break;

            }
            return response;
        }
    }
}
