import { AuditedEntityDto } from "@abp/ng.core";

export interface ContentDto extends AuditedEntityDto<string> {
  name: string;
  htmlContent: string;
}

export interface CreateUpdateContentDto {
  name: string;
  htmlContent: string;
}