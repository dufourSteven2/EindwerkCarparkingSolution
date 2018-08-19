"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var http_1 = require("@angular/http");
require("rxjs/add/operator/map");
var GeocodingApiService = /** @class */ (function () {
    function GeocodingApiService(http) {
        this.http = http;
        this.API_KEY = 'AIzaSyCeiTZY7jXETj0MpKuUbKwN_CqeUzv0v';
        this.API_URL = "https://maps.googleapis.com/maps/api/geocode/json?key=" + this.API_KEY + "&address=";
    }
    GeocodingApiService.prototype.findFromAddress = function (adres) {
        var compositeAddress = [adres];
        if (adres)
            compositeAddress.push(adres);
        var url = "" + this.API_URL + compositeAddress.join(',');
        return this.http.get(url).map(function (response) { return response.json(); });
    };
    GeocodingApiService = __decorate([
        core_1.Injectable(),
        __metadata("design:paramtypes", [http_1.Http])
    ], GeocodingApiService);
    return GeocodingApiService;
}());
exports.GeocodingApiService = GeocodingApiService;
//# sourceMappingURL=GeocodingApiService.js.map