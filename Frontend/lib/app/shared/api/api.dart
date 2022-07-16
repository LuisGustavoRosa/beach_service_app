import 'package:beach_service/app/shared/api/interceptors_api.dart';
import 'package:dio/native_imp.dart';

abstract class BaseURL {
  static String baseURL = "https://d87e-138-185-185-249.sa.ngrok.io";
}

class Api extends DioForNative {
  Api() {
    interceptors.add(InterceptorsApi());
  }
}
