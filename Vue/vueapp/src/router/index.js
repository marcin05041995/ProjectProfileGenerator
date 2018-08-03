import Vue from 'vue';
import Router from 'vue-router';
import Home from '@/components/Home';
import Project from '@/components/Project';
import Employee from '@/components/Employee';
import AddEmployee from '@/components/AddEmployee';
import AddProject from '@/components/AddProject';


Vue.use(Router);

export default new Router({
  routes: [
    {
      path: '/home',
      name: 'Home',
      component: Home,
    },
    {
      path: '/employee',
      name: 'Employee',
      component: Employee,
    },
    {
      path: '/project',
      name: 'Project',
      component: Project,
    },
    {
      path: '/addemployee',
      name: 'AddEmployee',
      component: AddEmployee,
    },
    {
      path: '/addproject',
      name: 'AddProject',
      component: AddProject,
    },
  ],
});
