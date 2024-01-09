import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'ContentManagementSystem',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44313/',
    redirectUri: baseUrl,
    clientId: 'ContentManagementSystem_App',
    responseType: 'code',
    scope: 'offline_access ContentManagementSystem',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44392',
      rootNamespace: 'ContentManagementSystem',
    },
  },
} as Environment;
