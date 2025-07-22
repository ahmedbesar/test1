import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl: 'http://localhost:4200/',
    name: 'test1',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44385/',
    redirectUri: baseUrl,
    clientId: 'test1_App',
    responseType: 'code',
    scope: 'offline_access test1',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44385',
      rootNamespace: 'test1',
    },
    test1: {
      url: 'https://localhost:44311',
      rootNamespace: 'test1',
    },
  },
} as Environment;
