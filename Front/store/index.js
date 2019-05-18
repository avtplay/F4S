export const state = () => ({
  news: [
    {
      id : 1,
      image : 'https://bulma.io/images/placeholders/1280x960.png',
      auteurImage: 'https://bulma.io/images/placeholders/96x96.png', 
      auteur: 'A Biesbrouck',
      text: 'Lorem Eiusmod velit ipsum amet dolore id laborum dolore sint voluptate reprehenderit proidentCupidatat voluptate non velit laborum ad laborum irure qui excepteur magna. Est labore Lorem reprehenderit proident elit laborum ipsum dolor irure excepteur nostrud sit minim. Quis commodo non commodo esse ipsum mollit reprehenderit sit fugiat amet sit. Culpa mollit ullamco exercitation qui in cillum aliqua. Do est magna duis veniam proident mollit.Nulla ad tempor cillum Lorem eiusmod id. Consequat excepteur reprehenderit cillum laborum reprehenderit nisi sit ex laboris. Labore occaecat sint adipisicing ullamco.',
      link: "www.facebook.com",
      linkLabel: "facebook",
      date: '28 juin 2017'

    },
    {
      id : 2,
      image : 'https://bulma.io/images/placeholders/1280x960.png',
      auteurImage: 'https://bulma.io/images/placeholders/96x96.png', 
      auteur: 'A Biesbrouck',
      text: 'Lorem Eiusmod velit ipsum amet dolore id laborum dolore sint voluptate reprehenderit proidentCupidatat voluptate non velit laborum ad laborum irure qui excepteur magna. Est labore Lorem reprehenderit proident elit laborum ipsum dolor irure excepteur nostrud sit minim. Quis commodo non commodo esse ipsum mollit reprehenderit sit fugiat amet sit. Culpa mollit ullamco exercitation qui in cillum aliqua. Do est magna duis veniam proident mollit.Nulla ad tempor cillum Lorem eiusmod id. Consequat excepteur reprehenderit cillum laborum reprehenderit nisi sit ex laboris. Labore occaecat sint adipisicing ullamco.',
      link: "www.facebook.com",
      linkLabel: "facebook",
      date: '28 juin 2017'

    },
    {
      id : 3,
      image : 'https://bulma.io/images/placeholders/1280x960.png',
      auteurImage: 'https://bulma.io/images/placeholders/96x96.png', 
      auteur: 'A Biesbrouck',
      text: 'Lorem Eiusmod velit ipsum amet proident elit laborum ipsum dolor irure excepteur nostrud sit minim. Quis commodo non commodo esse ipsum mollit reprehenderit sit fugiat amet sit. Culpa mollit ullamco exercitation qui in cillum aliqua. Do est magna duis veniam proident mollit.Nulla ad tempor cillum Lorem eiusmod id. Consequat excepteur reprehenderit cillum laborum reprehenderit nisi sit ex laboris. Labore occaecat sint adipisicing ullamco.',
      link: "www.facebook.com",
      linkLabel: "facebook",
      date: '28 juin 2017'

    },
    {
      id : 4,
      image : 'https://bulma.io/images/placeholders/1280x960.png',
      auteurImage: 'https://bulma.io/images/placeholders/96x96.png', 
      auteur: 'A Biesbrouck',
      text: 'Lorem Eiusmod velit ipsum amet proident elit laborum ipsum dolor irure excepteur nostrud sit minim. Quis commodo non commodo esse ipsum mollit reprehenderit sit fugiat amet sit. Culpa mollit ullamco exercitation qui in cillum aliqua. Do est magna duis veniam proident mollit.Nulla ad tempor cillum Lorem eiusmod id. Consequat excepteur reprehenderit cillum laborum reprehenderit nisi sit ex laboris. Labore occaecat sint adipisicing ullamco.',
      link: "www.facebook.com",
      linkLabel: "facebook",
      date: '28 juin 2017'

    }
  ],
  products: [
    {
      id: 1,
      title: 'Product 1',
      description: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit',
      price: 50,
      ratings: 3,
      reviews: 5,
      isAddedToCart: false,
      isAddedBtn: false,
      isFavourite: false,
      quantity: 1
    },
    {
      id: 2,
      title: 'Product 2',
      description: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit',
      price: 35,
      ratings: 5,
      reviews: 10,
      isAddedToCart: false,
      isAddedBtn: false,
      isFavourite: false,
      quantity: 1
    },
    {
      id: 3,
      title: 'Product 3',
      description: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit',
      price: 110,
      ratings: 2,
      reviews: 3,
      isAddedToCart: false,
      isAddedBtn: false,
      isFavourite: false,
      quantity: 1
    },
    {
      id: 4,
      title: 'Product 4',
      description: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit',
      price: 50,
      ratings: 1,
      reviews: 0,
      isAddedToCart: false,
      isAddedBtn: false,
      isFavourite: false,
      quantity: 1
    },
    {
      id: 5,
      title: 'Product 5',
      description: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit',
      price: 35,
      ratings: 4,
      reviews: 2,
      isAddedToCart: false,
      isAddedBtn: false,
      isFavourite: false,
      quantity: 1
    },
    {
      id: 6,
      title: 'Product 6',
      description: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit',
      price: 110,
      ratings: 5,
      reviews: 1,
      isAddedToCart: false,
      isAddedBtn: false,
      isFavourite: false,
      quantity: 1
    },
    {
      id: 7,
      title: 'Product 7',
      description: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit',
      price: 50,
      ratings: 5,
      reviews: 7,
      isAddedToCart: false,
      isAddedBtn: false,
      isFavourite: false,
      quantity: 1
    },
    {
      id: 8,
      title: 'Product 8',
      description: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit',
      price: 35,
      ratings: 3,
      reviews: 0,
      isAddedToCart: false,
      isAddedBtn: false,
      isFavourite: false,
      quantity: 1
    },
    {
      id: 9,
      title: 'Product 9',
      description: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit',
      price: 110,
      ratings: 4,
      reviews: 2,
      isAddedToCart: false,
      isAddedBtn: false,
      isFavourite: false,
      quantity: 1
    }
  ],
  userInfo: {
    isLoggedIn: false,
    isSignedUp: false,
    hasSearched: false,
    name: '',
    productTitleSearched: ''
  },
  systemInfo: {
    openLoginModal: false,
    openSignupModal: false,
    openCheckoutModal: false
  }
})

export const getters = {
  productsAdded: state => {
    return state.products.filter(el => {
      return el.isAddedToCart;
    });
  },
  productsAddedToFavourite: state => {
    return state.products.filter(el => {
      return el.isFavourite;
    });
  },
  getProductById: state => id => {
    return state.products.find(product => product.id == id);
  },
  isUserLoggedIn: state => {
    return state.userInfo.isLoggedIn;
  },
  isUserSignedUp: state => {
    return state.userInfo.isSignedUp;
  },
  getUserName: state => {
    return state.userInfo.name;
  },
  isLoginModalOpen: state => {
    return state.systemInfo.openLoginModal;
  },
  isSignupModalOpen: state => {
    return state.systemInfo.openSignupModal;
  },
  isCheckoutModalOpen: state => {
    return state.systemInfo.openCheckoutModal;
  },
  quantity: state => {
    return state.products.quantity;
  }
}

export const mutations = {
  addToCart: (state, id) => {
    state.products.forEach(el => {
      if (id === el.id) {
        el.isAddedToCart = true;
      }
    });
  },
  setAddedBtn: (state, data) => {
    state.products.forEach(el => {
      if (data.id === el.id) {
        el.isAddedBtn = data.status;
      }
    });
  },
  removeFromCart: (state, id) => {
    state.products.forEach(el => {
      if (id === el.id) {
        el.isAddedToCart = false;
      }
    });
  },
  removeProductsFromFavourite: state => {
    state.products.filter(el => {
      el.isFavourite = false;
    });
  },
  isUserLoggedIn: (state, isUserLoggedIn) => {
    state.userInfo.isLoggedIn = isUserLoggedIn;
  },
  isUserSignedUp: (state, isSignedUp) => {
    state.userInfo.isSignedUp = isSignedUp;
  },
  setHasUserSearched: (state, hasSearched) => {
    state.userInfo.hasSearched = hasSearched;
  },
  setUserName: (state, name) => {
    state.userInfo.name = name;
  },
  setProductTitleSearched: (state, titleSearched) => {
    state.userInfo.productTitleSearched = titleSearched;
  },
  showLoginModal: (state, show) => {
    state.systemInfo.openLoginModal = show;
  },
  showSignupModal: (state, show) => {
    state.systemInfo.openSignupModal = show;
  },
  showCheckoutModal: (state, show) => {
    state.systemInfo.openCheckoutModal = show;
  },
  addToFavourite: (state, id) => {
    state.products.forEach(el => {
      if (id === el.id) {
        el.isFavourite = true;
      }
    });
  },
  removeFromFavourite: (state, id) => {
    state.products.forEach(el => {
      if (id === el.id) {
        el.isFavourite = false;
      }
    });
  },
  quantity: (state, data) => {
    state.products.forEach(el => {
      if (data.id === el.id) {
        el.quantity = data.quantity;
      }
    });
  },
  SET_USER(state, authUser) {
    state.authUser = authUser
  }
}
/* 
export const actions = {
  async nuxtServerInit({ commit }) {
    const res = await this.$axios.get("/api/current_user")
    commit("SET_USER", res.data)
  },

  async logout({ commit }) {
    const { data } = await this.$axios.get("/api/logout")
    if (data.ok) commit("SET_USER", null)
  },

  async handleToken({ commit }, token) {
    const res = await this.$axios.post("/api/stripe", token)
    commit("SET_USER", res.data)
  }
} */
