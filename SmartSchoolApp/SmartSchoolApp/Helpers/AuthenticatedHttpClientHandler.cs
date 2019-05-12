using Acr.UserDialogs;
using ModernHttpClient;
using Refit;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SmartSchoolApp.Helpers
{
    public class AuthenticatedHttpClientHandler : NativeMessageHandler
    {
        /**
         * <summary>
         * Creates an instance of  <see cref="T:System.Net.Http.HttpResponseMessage" /> based on the
         * information provided in the <see cref="T:System.Net.Http.HttpRequestMessage" /> as an
         * operation that will not block.
         * </summary>
         *
         * <exception cref="UnauthorizedAccessException">   Thrown when an Unauthorized Access error
         *                                                  condition occurs. </exception>
         * <exception cref="OperationCanceledException">    Thrown when an Operation Canceled error
         *                                                  condition occurs. </exception>
         * <exception cref="WebException">                  Thrown when a Web error condition occurs. </exception>
         *
         * <param name="request">           The HTTP request message. </param>
         * <param name="cancellationToken"> A cancellation token to cancel the operation. </param>
         *
         * <returns>
         * Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the
         * asynchronous operation.
         * </returns>
        **/

        protected async override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
           
                // See if the request has an authorize header
                var auth = request.Headers.Authorization;

                try
                {
                    var response = await base.SendAsync(request, cancellationToken);

                    if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                        throw new UnauthorizedAccessException("Authentication error");

                    if (response.StatusCode == System.Net.HttpStatusCode.RequestTimeout)
                        await UserDialogs.Instance.AlertAsync("Service TimeOut.. Please try again..");

                    return response;
                }
                catch (Exception ex)
                {
                    if (ex is UnauthorizedAccessException)
                    {
                        throw new UnauthorizedAccessException("Authentication error");
                    }

                    if (ex is ApiException)
                    {
                        throw;
                    }
                    if (ex is OperationCanceledException)
                    {
                        throw new OperationCanceledException("Service TimeOut.. Please check your internet connection and try again..");
                    }

                    throw new WebException("No internet connection at the moment");
                }
            }
    }
}
