<template>
  <div>
    <VmHero></VmHero>
    <VmNewsList></VmNewsList>
  </div>
</template>

<script>
import VmNewsList from '@/components/products_list/ProductsListContainer';
import VmHero from '@/components/hero/Hero';

export default {
  name: 'index',
  components: {
    VmNewsList,
    VmHero
  }
};
</script>
