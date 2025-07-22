import { NgModule, NgModuleFactory, ModuleWithProviders } from '@angular/core';
import { CoreModule, LazyModuleFactory } from '@abp/ng.core';
import { ThemeSharedModule } from '@abp/ng.theme.shared';
import { test1Component } from './components/test1.component';
import { test1RoutingModule } from './test1-routing.module';

@NgModule({
  declarations: [test1Component],
  imports: [CoreModule, ThemeSharedModule, test1RoutingModule],
  exports: [test1Component],
})
export class test1Module {
  static forChild(): ModuleWithProviders<test1Module> {
    return {
      ngModule: test1Module,
      providers: [],
    };
  }

  static forLazy(): NgModuleFactory<test1Module> {
    return new LazyModuleFactory(test1Module.forChild());
  }
}
