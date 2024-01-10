import { RestService } from "@abp/ng.core";
import { Injectable } from "@angular/core";
import { ContentDto } from "./models";

@Injectable({
    providedIn: 'root',
})
export class ContentService {
    apiName = 'Default';

    getContent = (id: string) =>
        this.restService.request<any, ContentDto>({
            method: 'GET',
            url: `/api/content/GetCMSContent/${id}`,
        },
            { apiName: this.apiName });

    constructor(private restService: RestService) { }
}