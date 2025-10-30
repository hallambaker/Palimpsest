//using Goedel.Cryptography;
//using Goedel.IO;
//using Goedel.Protocol;

//using Microsoft.Extensions.Options;

//namespace Mplace2.Gui;





//class MainClass {

//    public static List<Option> MakeOptions(params string[] identifiers) => MakeOptions<Option>(identifiers);

//    public static List<T> MakeOptions<T>(params string[] identifiers) where T : Option, new() {
//        var result = new List<T>();

//        foreach (string identifier in identifiers) {
//            var option = new T() {
//                Id = identifier.ToLower(),
//                Text =identifier,
//                Icon = identifier,
//                Priority = 0
//                };
//            result.Add(option);
//            }

//        return result;
//        }

//    public static void AddOptions<T>(
//            List<T> options, int priority, params string[] identifiers) where T : Option, new() {

//        foreach (string identifier in identifiers) {
//            var option = new T() {
//                Id = identifier.ToLower(),
//                Text = identifier,
//                Icon = identifier,
//                Priority = priority
//                };
//            options.Add(option);
//            }

//        }

//    public static void AddOptionsNoIcons<T>(
//                List<T> options, params string[] identifiers) where T : Option, new() {

//        foreach (string identifier in identifiers) {
//            var option = new T() {
//                Id = identifier.ToLower(),
//                Text = identifier
//                };
//            options.Add(option);
//            }

//        }

//    public static void SetIcon<T>(List<T> options, string id, string icon) where T : Option {

//        foreach (var option in options) {
//            if (option.Id == id.ToLower()) {
//                option.Icon = icon;
//                return;
//                }
//            }
//        }

//    public static List<T> FixIds<T>(List<T> options) where T : Option {

//        foreach (var option in options) {
//            option.Id = option.Text.ToLower();
//            option.Icon ??= option.Text;
//            }

//        return options;
//        }

//    }
//public partial class Option {



//    }
