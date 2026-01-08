using Microsoft.JSInterop;
using System.Threading.Tasks;
using System.Text.Json;
using VitaForgeWeb.Models;

namespace VitaForgeWeb.Services
{
    public class FirebaseService
    {
        private readonly IJSRuntime _jsRuntime;

        public FirebaseService(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        public async Task<AuthResult> LoginAsync(string email, string password)
        {
            return await _jsRuntime.InvokeAsync<AuthResult>("vitaForge.login", email, password);
        }

        public async Task<AuthResult> RegisterAsync(string email, string password)
        {
            return await _jsRuntime.InvokeAsync<AuthResult>("vitaForge.register", email, password);
        }

        public async Task LogoutAsync()
        {
            await _jsRuntime.InvokeVoidAsync("vitaForge.logout");
        }

        public async Task<bool> SaveUserDataAsync(string uid, Usuario usuario)
        {
            var json = JsonSerializer.Serialize(usuario, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
            });

            var result = await _jsRuntime.InvokeAsync<OperationResult>("vitaForge.saveUserData", uid, json);
            return result.Success;
        }

        public async Task<Usuario?> GetUserDataAsync(string uid)
        {
            var result = await _jsRuntime.InvokeAsync<DataResult>("vitaForge.getUserData", uid);
            if (result.Success && !string.IsNullOrEmpty(result.Data))
            {
                return JsonSerializer.Deserialize<Usuario>(result.Data, new JsonSerializerOptions
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                });
            }
            return null;
        }

        public async Task<CurrentUser?> GetCurrentUserAsync()
        {
            return await _jsRuntime.InvokeAsync<CurrentUser?>("vitaForge.getCurrentUser");
        }
    }

    public class AuthResult
    {
        public bool Success { get; set; }
        public string? Uid { get; set; }
        public string? Email { get; set; }
        public string? Error { get; set; }
    }

    public class OperationResult
    {
        public bool Success { get; set; }
        public string? Error { get; set; }
    }

    public class DataResult
    {
        public bool Success { get; set; }
        public string? Data { get; set; } // JSON string
        public string? Error { get; set; }
    }

    public class CurrentUser
    {
        public string? Uid { get; set; } // Firebase UID
        public string? Email { get; set; }
    }
}
