import { ModuleWithProviders, NgModule } from '@angular/core';
import { TEST1_ROUTE_PROVIDERS } from './providers/route.provider';

@NgModule()
export class test1ConfigModule {
  static forRoot(): ModuleWithProviders<test1ConfigModule> {
    return {
      ngModule: test1ConfigModule,
      providers: [TEST1_ROUTE_PROVIDERS],
    };
  }
}
