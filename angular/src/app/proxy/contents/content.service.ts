import { PagedResultDto, RestService } from "@abp/ng.core";
import { Injectable } from "@angular/core";
import { ContentDto, CreateUpdateContentDto } from "./models";

@Injectable({
    providedIn: 'root',
})
export class ContentService {
    apiName = 'Default';

    constructor(private restService: RestService) { }

    getContent = (id: string) =>
        this.restService.request<any, ContentDto>({
            method: 'GET',
            url: `/api/content/GetCMSContent/${id}`,
        },
            { apiName: this.apiName });

    GetAll = () =>
        this.restService.request<any, PagedResultDto<ContentDto>>({
            method: 'GET',
            url: `/api/content/GetAll`,
        },
            { apiName: this.apiName });

    InsertOrUpdateCMSContent = (body: CreateUpdateContentDto) =>
        this.restService.request<any, ContentDto>({
            method: 'POST',
            url: `/api/content/InsertOrUpdateCMSContent`,
            body: body
        },
            { apiName: this.apiName });
}