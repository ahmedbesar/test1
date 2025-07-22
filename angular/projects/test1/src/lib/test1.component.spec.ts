import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';
import { test1Component } from './components/test1.component';
import { test1Service } from '@test1';
import { of } from 'rxjs';

describe('test1Component', () => {
  let component: test1Component;
  let fixture: ComponentFixture<test1Component>;
  const mocktest1Service = jasmine.createSpyObj('test1Service', {
    sample: of([]),
  });
  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [test1Component],
      providers: [
        {
          provide: test1Service,
          useValue: mocktest1Service,
        },
      ],
    }).compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(test1Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
