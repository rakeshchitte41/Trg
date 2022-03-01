import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GraphicalrouteComponent } from './graphicalroute.component';

describe('GraphicalrouteComponent', () => {
  let component: GraphicalrouteComponent;
  let fixture: ComponentFixture<GraphicalrouteComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GraphicalrouteComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(GraphicalrouteComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
