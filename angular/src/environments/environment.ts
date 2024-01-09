import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'ContentManagementSystem',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'http://localhost:44313/',
    redirectUri: baseUrl,
    clientId: 'ContentManagementSystem_App',
    responseType: 'code',
    scope: 'offline_access ContentManagementSystem',
    requireHttps: false,
  },
  apis: {
    default: {
      url: 'http://localhost:44392',
      rootNamespace: 'ContentManagementSystem',
    },
  },
} as Environment;
